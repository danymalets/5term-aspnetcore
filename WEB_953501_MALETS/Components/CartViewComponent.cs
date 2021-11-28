using Microsoft.AspNetCore.Mvc;
using WEB_953501_MALETS.Extensions;
using WEB_953501_MALETS.Models;

namespace WEB_953501_MALETS.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<Cart>("cart");
            return View(cart);
        }
    }
}