using System.Windows.Forms;
using Microsoft.Extensions.Logging;

namespace OrderManagement
{
    public partial class OrderManagement : Form
    {
        private readonly ILogger<OrderManagement> _logger;

        public OrderManagement(ILogger<OrderManagement> logger)
        {
            _logger = logger;
            InitializeComponent();
        }
    }
}
