using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPaged.WF;
using VPaged.WF.VProperties;

namespace VPaged.Example
{
    public partial class Form1 : Form
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee() {ID = 1 ,Name = "Levi1", Department = "IT"},
            new Employee() {ID = 2 ,Name = "Levi2", Department = "IT"},
            new Employee() {ID = 3 ,Name = "Levi3", Department = "IT"},
            new Employee() {ID = 4 ,Name = "Levi4", Department = "IT"},
            new Employee() {ID = 5 ,Name = "Levi5", Department = "IT"},
            new Employee() {ID = 6 ,Name = "Levi6", Department = "IT"},
            new Employee() {ID = 7 ,Name = "Levi7", Department = "IT"},
            new Employee() {ID = 8 ,Name = "Levi8", Department = "IT"},
            new Employee() {ID = 9 ,Name = "Levi9", Department = "IT"}
        };

        private VPagination<Form1> _pag;

        public Form1()
        {
            InitializeComponent();
            _pag = new VPagination<Form1>(this, pageSize: 5, startWhenIntialize: true);
            _pag.GetPaginationUI(this.ContainerPager);
            _pag.SelectDataMaster = () => this.SelectData();
        }

        public async Task SelectData()
        {
            //handler data
            var result = employees.Skip((_pag.PageIndex - 1) * _pag.PageSize).Take(_pag.PageSize).ToList();
            int count = employees.Count();

            //paging
            _pag.Pagination(result, (long)count, ref GridMaster);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee() { ID = 111, Name = "Created", Department = "OK" });
            _pag.VPagRunOrRefresh();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            employees.Remove(employees.FirstOrDefault());
            _pag.VPagRunOrRefresh();
        }
    }
}
