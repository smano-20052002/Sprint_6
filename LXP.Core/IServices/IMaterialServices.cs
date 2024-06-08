using LXP.Common.ViewModels;


namespace LXP.Core.IServices
{
    public interface IMaterialServices
    {
        Task<List<MaterialListViewModel>> GetAllMaterialDetailsByTopicAndType(string topicId, string materialTypeId);
        Task<MaterialListViewModel> AddMaterial(MaterialViewModel material);
        Task<MaterialListViewModel> GetMaterialByMaterialNameAndTopic(string materialName, string topicId);
        Task<bool> SoftDeleteMaterial(string materialId);
        Task<bool> UpdateMaterial(MaterialUpdateViewModel material);

        Task<MaterialListViewModel> GetMaterialDetailsByMaterialId(string materialId);
        
        Task<MaterialListViewModel> GetMaterialDetailsByMaterialIdWithoutPDFConversionForUpdate(string materialId);

    }
}
