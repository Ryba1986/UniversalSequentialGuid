namespace UniversalSequentialGuid
{
   public sealed class SequentialGeneratorOptions
   {
      public GuidType GuidType { get; init; }

      public SequentialGeneratorOptions()
      {
         GuidType = GuidType.Net;
      }
   }
}
