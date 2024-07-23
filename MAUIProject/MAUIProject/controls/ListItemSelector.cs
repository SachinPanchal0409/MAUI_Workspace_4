using MAUIProject.Models;

namespace MAUIProject.controls
{
    public class ListItemSelector : DataTemplateSelector
    {
        public DataTemplate FoodTemplateList { get; set; }
        public DataTemplate BeverageTemplateList { get; set; }



        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ListViewModel viewModel)
            {
                if (viewModel.Type == "Food")
                {
                    return FoodTemplateList;
                }
                else if (viewModel.Type == "Beverages")
                {
                    return BeverageTemplateList;
                }
            }

            return OnSelectTemplate(item, container);
        }
    }
}
