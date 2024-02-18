using System;

namespace UniversalSequentialGuid
{
   public interface ISequentialGenerator
   {
      Guid NewGuid();
   }
}
