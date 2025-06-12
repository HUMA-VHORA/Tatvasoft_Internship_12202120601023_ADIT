using Mission.Entities.Models;
using System.Collections.Generic;
using Mission.Services.IServices;

namespace Mission.Services.IServices
{
   
    public interface IMissionSkillService
    {
        IEnumerable<MissionSkillModel> GetMissionSkillList();
        MissionSkillModel GetMissionSkillById(int id);
        MissionSkillModel AddMissionSkill(AddMissionSkillRequestModel model);
        MissionSkillModel UpdateMissionSkill(UpdateMissionSkillRequestModel model);
        bool DeleteMissionSkill(int id);
    }

}
