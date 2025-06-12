using Canteen.Model;
using Canteen.View;

namespace Canteen.Controller
{
    public class CartController
    {
        private SqlHelper helper;
        private List<Menu> order;
        public CartController()
        {
            helper = new SqlHelper();
        }
    }
}
