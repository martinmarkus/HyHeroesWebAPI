using HyHeroesWebAPI.Presentation.Attributes;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Linq;

namespace HyHeroesWebAPI.Presentation.Conventions
{
    public class ControllerNameAttributeConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNameAttribute = controller.Attributes.OfType<ControllerNameAttribute>().SingleOrDefault();
            if (controllerNameAttribute != null)
            {
                controller.ControllerName = controllerNameAttribute.Name;
            }
        }
    }
}
