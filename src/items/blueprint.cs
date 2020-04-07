using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace VSExampleMods
{
    public class BlueprintMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("blueprintHolder", typeof(BlueprintHolder));
        }
    }

    public class BlueprintHolder : Block
    {
      // It does NOTHING :P
    }
}
