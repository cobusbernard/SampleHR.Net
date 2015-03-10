using System.Collections.Generic;
using SampleHR.Net.Core.DTOs;

namespace SampleHR.Net.Core.Contracts.Repositories
{
    public interface ISettingsRepository
    {
        List<SettingDTO> GetAllSettings();
    }
}
