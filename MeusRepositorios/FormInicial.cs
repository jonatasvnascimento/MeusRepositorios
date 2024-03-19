using MeusRepositorios.Domain.Model;
using MeusRepositorios.Service.Interface;
using MeusRepositorios.Service.Services;

namespace MeusRepositorios
{
    public partial class FormInicial : Form
    {
        private MyRepositoryService _myRepositoryService;
        public List<MyRepository> myRepository { get; set; }
        public FormInicial()
        {
            InitializeComponent();
            _myRepositoryService = new MyRepositoryService();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            myRepository = _myRepositoryService.Get().ToList();
        }
    }
}
