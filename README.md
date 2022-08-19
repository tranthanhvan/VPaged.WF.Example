# VPaged.WF Pagination component for winform base
This library will help you to paginate with winform easily.
Source : https://github.com/tranthanhvan/VPaged.WF

# How to use

### Simple example : Initialize a VPag with the current Form ,set method you use to get data in SelectDataMaster and run:
```csharp
    public partial class Form1 : Form
    {
        private VPagination<Form1> _pag;

        public Form1()
        {
            InitializeComponent();
            _pag = new VPagination<Form1>(this, pageSize: 5, startWhenIntialize: true);
            _pag.GetPaginationUI(this.ContainerPager); //Get display pager. in this example 'this.ContainerPager' is a GroupBox
            _pag.SelectDataMaster = () => this.SelectData(); // Function select data eg below:
        }
        
        public async Task SelectData()
        {
            //handler data
            var result = employees.Skip((_pag.PageIndex - 1) * _pag.PageSize).Take(_pag.PageSize).ToList();
            int count = employees.Count();

            //paging
            _pag.Pagination(result, (long)count, ref GridMaster); // GridMaster is DataGridView.
        }
    }
```





