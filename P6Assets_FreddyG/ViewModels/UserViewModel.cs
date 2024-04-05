using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P6Assets_FreddyG.Models;

namespace P6Assets_FreddyG.ViewModels {
    public class UserViewModel : BaseViewModel {
        public UserPost MyUserToPost { get; set; }
        public UserViewModel()
        {
            MyUserToPost = new UserPost();
        }
    }
}
