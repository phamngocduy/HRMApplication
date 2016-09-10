using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Script.Serialization;

using HRM.Accounts.Models;
using HRM.Accounts.Filters;
namespace HRM.Accounts.Controllers
{
    public class PermissionController : Controller
    {
        [HttpPost]
        public string Roles()
        {
            using (var context = new UsersContext())
                return new JavaScriptSerializer().Serialize(
                    (from role in context.RoleProfiles
                     orderby role.RoleId descending select role)
                    .AsEnumerable().Select(role => new
                    {
                        RoleId = role.RoleId,
                        RoleName = role.RoleName,
                        Actions = String.Join(",", (from behavior in role.GetBehaviors() select behavior.Id).ToArray()),
                        Summary = String.Format("{0} users and {1} permissions", role.GetUsers().Count(), role.GetBehaviors().Count())
                    }));
        }

        [HttpPost]
        public string EditRole(string oper, RoleProfile model)
        {
            if (String.IsNullOrEmpty(model.RoleName))
                return "RoleName is required.";
            else
                using (var context = new UsersContext())
                {
                    var role = context.RoleProfiles.SingleOrDefault(r => r.RoleName == model.RoleName);
                    if ("add".Equals(oper))
                        if (role == null)
                        {
                            context.RoleProfiles.Add(new RoleProfile(model.RoleName));
                            context.SaveChanges();
                        }
                        else return model.RoleName + " already exists.";
                    if ("edit".Equals(oper))
                        if (role == null)
                        {
                            role = context.RoleProfiles.Single(r => r.RoleId == model.RoleId);
                            role.RoleName = model.RoleName;
                            context.Entry(role).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        else return model.RoleName + " already exists.";
                    if ("del".Equals(oper))
                        if (role != null)
                        {
                            if (role.RoleId == 1)
                                return "Cannot delete administration.";
                            context.RoleProfiles.Remove(role);
                            context.SaveChanges();
                        }
                        else return "RoleName not found.";
                }
            return "";
        }

        [HttpPost]
        public string Actions()
        {
            using (var context = new UsersContext())
                return new JavaScriptSerializer().Serialize(
                    (from behavior in context.Behaviors
                     orderby behavior.Id descending
                     select behavior)
                    .AsEnumerable().Select(behavior => new
                    {
                        Id = behavior.Id,
                        Controller = behavior.Controller,
                        Action = behavior.Action
                    }));
        }

        [HttpPost]
        public string EditAction(string oper, Behavior model)
        {
            if (String.IsNullOrEmpty(model.Controller) || String.IsNullOrEmpty(model.Action))
                return "Controller and Action are required.";
            else
                using (var context = new UsersContext())
                {
                    var behavior = context.Behaviors.SingleOrDefault(b => b.Id == model.Id);
                    if ("add".Equals(oper))
                    {
                        context.Behaviors.Add(new Behavior(model.Controller, model.Action));
                        context.SaveChanges();
                    }
                    if ("edit".Equals(oper))
                        if (behavior != null)
                        {
                            behavior.Controller = model.Controller;
                            behavior.Action = model.Action;
                            context.Entry(behavior).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        else return "Action Id not found.";
                    if ("del".Equals(oper))
                        if (behavior != null)
                        {
                            context.Behaviors.Remove(behavior);
                            context.SaveChanges();
                        }
                        else return "Action Id not found.";
                }
            return "";
        }

        [HttpPost]
        public string SaveAction(int roleId, int[] actionIds)
        {
            List<int> actions = new List<int>();
            if (actionIds != null)
                actions = new List<int>(actionIds);
            using (var context = new UsersContext())
            {
                var role = context.RoleProfiles.SingleOrDefault(r => r.RoleId == roleId);
                if (role != null)
                {
                    var delete = context.RolesActions.Where(r => r.RoleId == roleId);
                    foreach (var action in delete)
                        context.RolesActions.Remove(action);
                    foreach (var action in actions)
                        context.RolesActions.Add(new RoleAction() { RoleId = roleId, ActionId = action });
                    context.SaveChanges();
                }
                else return "Role Id not found.";
            }
            return "";
        }

        public ActionResult EditActions(int id)
        {
            using (var context = new UsersContext())
            {
                return View(context.Behaviors.Find(id));
            }
        }

        [HttpPost]
        public ActionResult EditActions(Behavior model)
        {
            if (String.IsNullOrEmpty(model.Action))
                ModelState.AddModelError("Action", "Action is required.");
            if (ModelState.IsValid)
                using (var context = new UsersContext()){
                    context.Entry(model).State = EntityState.Modified;
                    context.SaveChanges();
                    ModelState.AddModelError("", "Update successfully.");
                }
            return View(model);
        }
    }
}
