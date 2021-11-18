using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicRoleModel dynamicRoleModel = new DynamicRoleModel();
            string[] newPermissions = { "mangeMember", "AdminMember" };
            SetPropertyWithValue(dynamicRoleModel, newPermissions);
        }
        public static void SetPropertyWithValue<T>(T obj, string[] newPermissions)
        {
            foreach (var item in newPermissions)
            {
                var type = obj.GetType();
                var props = type.GetProperties();

                var prop = props.FirstOrDefault(x =>x.Name.Equals(item,StringComparison.OrdinalIgnoreCase));
                if (prop!=null)
                {
                    var d=prop.GetValue(obj);
                    prop.SetValue(obj, true);
                    var g = prop.GetValue(obj);
                }
            }
        }
    }
}
