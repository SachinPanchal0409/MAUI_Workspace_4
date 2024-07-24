using MAUIProject.Models;

namespace MAUIProject.controls
{
    public class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FoodTemplate { get; set; }
        public DataTemplate BeverageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is CollectionViewModel viewModel)
            {
                if (viewModel.Type == "Food")
                {
                    return FoodTemplate;
                }
                else if (viewModel.Type == "Beverages")
                {
                    return BeverageTemplate;
                }
            }

            return OnSelectTemplate(item, container);
        }

    }
}
