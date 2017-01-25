using System.Collections.Generic;

namespace SwarmAthon.DataServices.Online.Dto
{
    public class VersionSubmitDto
    {
        public UserDto User { get; set; }
        public List<CasesDto> Cases { get; set; }
    }
}