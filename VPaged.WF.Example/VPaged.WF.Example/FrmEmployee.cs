using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VPaged.WF.Example.DbAccess;
using VPaged.WF.Example.Entities;

namespace VPaged.WF.Example
{
    public partial class FrmEmployee : Form
    {
        private static string ID = string.Empty;
        private readonly VPagedContext _context;

        private VPagination _pag;

        public FrmEmployee()
        {
            InitializeComponent();
            _context = new VPagedContext();
            //Initilizer VPaged.WF. `this.groupPaging` is System.Windows.Forms.GroupBox type Winform Base
            _pag = new VPagination(this.ContainerPaging, pageSize: 3);
            //Set method Select Data
            _pag.SelectDataMaster = SelectData;
            //Set method get count need paging
            _pag.SelectCountMaster = GetCount;
        }

        /// <summary>
        /// Method VPaged SelectDataMaster
        /// </summary>
        private void SelectData()
        {
            List<Employee> datas = _context.Employees.OrderBy(p => p.ID).Skip((_pag.PageIndex - 1) * _pag.PageSize).Take(_pag.PageSize).ToList();
            _pag.Pagination(datas, ref GridMaster); // GridMaster is DataGridView.
        }

        /// <summary>
        /// Method VPaged SelectCountMaster
        /// </summary>
        /// <returns>total count need paging</returns>
        private long GetCount() => _context.Employees.Count();

        private void BtnLoad_Click(object sender, System.EventArgs e)
        {
            _pag.VPagRunOrRefresh();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
                MessageBox.Show("Name is empty");
            else
            {
                bool result = false;
                if (string.IsNullOrEmpty(ID))
                {
                    //Create
                    _context.Employees.Add(new Employee()
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = name
                    });
                    result = _context.SaveChanges() > 0;
                    ClearModel();
                }
                else
                {
                    //Update
                    var entity = _context.Employees.FirstOrDefault(x => x.ID.Equals(ID));
                    if (entity != null)
                    {
                        entity.Name = name;
                        result = _context.SaveChanges() > 0;
                        ClearModel();
                    }
                }

                if (result)
                {
                    MessageBox.Show("Save success");
                    _pag.VPagRunOrRefresh();
                }
            }
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Customer is not select");
            }
            else
            {
                //Delete
                var entity = _context.Employees.FirstOrDefault(x => x.ID.Equals(ID));
                if (entity != null)
                {
                    _context.Employees.Remove(entity);
                    _context.SaveChanges();
                    ClearModel();
                    _pag.VPagRunOrRefresh();
                    MessageBox.Show("Customer is deleted");
                }
            }
        }

        private void ClearModel()
        {
            ID = string.Empty;
            txtName.Clear();
            lblID.Text = "ID :";
        }

        private void GridMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = GridMaster.CurrentRow.Cells["Id"].Value.ToString();
            if (string.IsNullOrEmpty(ID))
                return;
            else
            {
                lblID.Text = "ID : " + ID;
                var entity = _context.Employees.FirstOrDefault(x => x.ID.Equals(ID));
                if (entity != null)
                {
                    txtName.Text = entity.Name;
                }
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            _pag.VPagRunOrRefresh();
        }
    }
}
