using System.Collections.Generic;

namespace SwarmAthon.DataServices.Online.Dto
{
    public class CasesDto
    {
        public string Id { get; set; }
        public string Result { get; set; }
        public string Description { get; set; }
        public List<string> Steps { get; set; }
    }
}