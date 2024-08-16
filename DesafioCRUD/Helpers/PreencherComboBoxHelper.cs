using DesafioCRUD.Results;
using System.ComponentModel;
using System.Reflection;

namespace DesafioCRUD.Domain.Helpers
{
    public static class PreencherComboBoxHelper
    {
        public static void PreencherComboComEnum<T>(ComboBox comboBox) where T : Enum
        {
            var type = typeof(T);
            var values = Enum.GetValues(type).Cast<T>();

            foreach (var item in values)
            {
                var field = type.GetField(item.ToString());
                var descriptionAttribute = field?.GetCustomAttribute<DescriptionAttribute>();
                var description = descriptionAttribute != null ? descriptionAttribute.Description : item.ToString();
                comboBox.Items.Add(new EnumDescricao<T>(item, description));
            }

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";
        }
    }
}
