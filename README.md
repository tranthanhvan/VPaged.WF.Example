# VPaged.WF Pagination component for .NET desktop application 
This library will help you to paginate desktop application easily with C#.
Source : https://github.com/tranthanhvan/VPaged.WF

![alt text](https://github.com/tranthanhvan/VPaged.WF.Example/blob/main/WF.png)

# Install

```dotnet add package VPaged.WF --version 2.0.1``` 

# How to Use

### With Winform application

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
        => GridMaster.DataSource = _context.Employees.OrderBy(p => p.ID).Skip((_pag.PageIndex - 1) * _pag.PageSize)
                                    .Take(_pag.PageSize).ToList(); //GridMaster is DataGridView

        /// <summary>
        /// Method VPaged SelectCountMaster
        /// </summary>
        /// <returns>total count need paging</returns>
        private long GetCount() => _context.Employees.Count();
    }
```

#### VPagRunOrRefresh() method used to run get data or can also refresh data after insert/update or delete . After Initialize a VPag , call VPagRunOrRefresh() Method to run. ex i will run VPag get Data and paging when Form load events :
```csharp
    private void FrmEmployee_Load(object sender, EventArgs e)
    {
	_pag.VPagRunOrRefresh();
    }
```
#### Or create a button with click event is run VPaged :
```csharp
    private void BtnLoad_Click(object sender, System.EventArgs e)
    {
        _pag.VPagRunOrRefresh();
    }
```

### With WPF application

![alt text](https://github.com/tranthanhvan/VPaged.WF.Example/blob/main/WPF.png)

#### it's still the same. just create System.WindowForms.Control to initialize VPaged . eg :
```XAML
    <WindowsFormsHost Margin="257,237,276,354" Width="500" Height="50" Name="HostNamePagingWF">
        <wf:Control x:Name="ContainerPaging" Text="Here" Height="48" Width="370"/>
    </WindowsFormsHost>
```

#### The rest is similar to the window form application:

```csharp
    public partial class MainWindow : Window
    {
        private readonly VPagedContext _context;

        private VPagination _pag;

        public MainWindow()
        {
            InitializeComponent();
            _context = new VPagedContext();
            //Initilizer VPaged.WF. `this.groupPaging` is System.Windows.Forms.GroupBox type Winform Base
            _pag = new VPagination(ContainerPaging, pageSize: 3); //ContainerPaging is child WindowsFormsHost
            //Set method Select Data
            _pag.SelectDataMaster = SelectData;
            //Set method get count need paging
            _pag.SelectCountMaster = GetCount;
        }

        /// <summary>
        /// Method VPaged SelectDataMaster
        /// </summary>
        private void SelectData()
        => GridView.ItemsSource = _context.Employees.OrderBy(p => p.ID).Skip((_pag.PageIndex - 1) * _pag.PageSize)
                                    .Take(_pag.PageSize).ToList();

        /// <summary>
        /// Method VPaged SelectCountMaster
        /// </summary>
        /// <returns>total count need paging</returns>
        private long GetCount() => _context.Employees.Count();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _pag.VPagRunOrRefresh();
        }
    }
```
