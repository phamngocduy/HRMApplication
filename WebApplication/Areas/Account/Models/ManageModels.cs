using System;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

using HRM.Accounts.Filters;
namespace HRM.Accounts.Models
{
    public class ChangeUserNameModel : UserNameModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string Password { get; set; }
    }

    public class ChangePasswordModel : PasswordModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ManageViewModel
    {
        public ManageViewModel(string userName)
        {
            ChangeUserNameModel = new ChangeUserNameModel() { UserName = userName };
            ChangePasswordModel = new ChangePasswordModel();
        }
        public ChangeUserNameModel ChangeUserNameModel { get; private set; }
        public ChangePasswordModel ChangePasswordModel { get; private set; }
    }

    public class RegisterUserModel
    {
        [Required]
        [Display(Name = "User name")]
        public string Account { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int UserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class DeleteAccountModel
    {
        [Required]
        [Range(2, int.MaxValue)]
        public int UserId { get; set; }
    }

    public class SetPermissionModel
    {
        [Required]
        [Range(2, int.MaxValue)]
        public int UserId { get; set; }

        public string Permissions { get; set; }
    }

    public class ManageUsersViewModel
    {
        public ManageUsersViewModel()
        {
            using (var context = new UsersContext())
            {
                UserProfiles = context.UserProfiles.ToArray();
                RoleProfiles = context.RoleProfiles.ToArray();
            }
        }

        public UserProfile[] UserProfiles { get; private set; }
        public RoleProfile[] RoleProfiles { get; private set; }
    }
}
