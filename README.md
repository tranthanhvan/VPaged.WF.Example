# VPaged.WF Pagination component for winform base
This library will help you to paginate with winform easily.
Source : https://github.com/tranthanhvan/VPaged.WF

# Install

CLI : ```dotnet add package VPaged.WF --version 2.0.0``` 

# How to Use

#### Initialize a VPag with the current Form ,set method you use to get data & totalCount in SelectDataMaster & SelectCountMaster properties:
```csharp
    public partial class FrmEmployee : Form
    {
        private readonly VPagedContext _context;

        private VPagination _pag;

        public FrmEmployee()
        {
            InitializeComponent();
            _context = new VPagedContext();
            //Initilizer VPaged.WF. `this.groupPaging` is System.Windows.Forms.GroupBox type Winform Base
            _pag = new VPagination(this.groupPaging, pageSize: 3); 
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
            _pag.Pagination(datas.AsEnumerable(), ref GridMaster); // GridMaster is DataGridView.
        }

        /// <summary>
        /// Method VPaged SelectCountMaster
        /// </summary>
        /// <returns>total count need paging</returns>
        private long GetCount() => _context.Employees.Count();
    }
```
