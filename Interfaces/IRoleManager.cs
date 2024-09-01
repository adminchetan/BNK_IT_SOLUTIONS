using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Uttaraonline.Models;

namespace Uttaraonline.Interfaces
{

    
    public interface IRoleManager
    {
        public string GetLeftMenuItems();
    }
}
