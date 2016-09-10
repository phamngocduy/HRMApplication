using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Accounts.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("AuthConnection")
        {
        }

        public DbSet<Behavior> Behaviors { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<RoleProfile> RoleProfiles { get; set; }
        public DbSet<UserInRole> UsersInRoles { get; set; }
        public DbSet<RoleAction> RolesActions { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        public UserProfile()
        {
            UserInRoles = new HashSet<UserInRole>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastActivityDate { get; set; }

        public virtual ICollection<UserInRole> UserInRoles { get; set; }
        public RoleProfile[] GetRoles()
        {
            return (from u_r in UserInRoles select u_r.Role).ToArray();
        }
    }

    public class UserNameModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class PasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    [Table("RoleProfile")]
    public class RoleProfile
    {
        public RoleProfile()
        {
            UsersInRole = new HashSet<UserInRole>();
            RoleActions = new HashSet<RoleAction>();
        }
        public RoleProfile(string roleName)
            : this()
        {
            RoleName = roleName;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserInRole> UsersInRole { get; set; }
        public virtual ICollection<RoleAction> RoleActions { get; set; }
        public UserProfile[] GetUsers()
        {
            return (from u_r in UsersInRole select u_r.User).ToArray();
        }
        public Behavior[] GetBehaviors()
        {
            return (from r_a in RoleActions select r_a.Behavior).ToArray();
        }
    }

    [Table("Behavior")]
    public class Behavior
    {
        public Behavior()
        {
            RolesAction = new HashSet<RoleAction>();
        }
        public Behavior(string controller, string action)
            : this()
        {
            Controller = controller;
            Action = action;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public virtual ICollection<RoleAction> RolesAction { get; set; }
    }

    [Table("RoleAction")]
    public class RoleAction
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ActionId { get; set; }

        [ForeignKey("ActionId")]
        public virtual Behavior Behavior { get; set; }
        [ForeignKey("RoleId")]
        public virtual RoleProfile RoleProfile { get; set; }
    }

    [Table("UserInRole")]
    public class UserInRole
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile User { get; set; }
        [ForeignKey("RoleId")]
        public virtual RoleProfile Role { get; set; }
    }
}
