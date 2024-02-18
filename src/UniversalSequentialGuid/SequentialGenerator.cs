using System;
using System.Security.Cryptography;

namespace UniversalSequentialGuid
{
   public sealed class SequentialGenerator : ISequentialGenerator
   {
      private readonly SequentialGeneratorOptions _options;
      private readonly byte[] _i;

      public SequentialGenerator(SequentialGeneratorOptions? options = null)
      {
         _options = options is not null
            ? options
            : new();

         _i = RandomNumberGenerator.GetBytes(4);
      }

      public Guid NewGuid()
      {
         byte[] t = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
         byte[] r = RandomNumberGenerator.GetBytes(4);

         return _options.GuidType switch
         {
            GuidType.Net => new([t[4], t[5], t[6], t[7], t[2], t[3], t[0], t[1], _i[2], _i[3], _i[1], _i[0], r[3], r[2], r[1], r[0]]),
            GuidType.MsSql => new([r[3], r[2], r[1], r[0], _i[1], _i[0], _i[3], _i[2], t[1], t[0], t[7], t[6], t[5], t[4], t[3], t[2]]),
            GuidType.PostgreSql => new([t[7], t[6], t[5], t[4], t[3], t[2], t[1], t[0], _i[3], _i[2], _i[1], _i[0], r[3], r[2], r[1], r[0]]),
            _ => throw new NotImplementedException("Guid type is undefined."),
         };
      }
   }
}
