using System.Collections.Generic;

using Graduation.Core;

namespace Graduation.Web.Models
{
    public record DepartmentModel
    {
        public string Code { get; set; }

        public string Name { get; init; }
    }

    public record QualificationTypeModel
    {
        public string Name { get; set; }
    }

    public record AbilityModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }

    public record OperationalDifficultyModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }

    public record DisabilityAidModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }

    public record LearningDifficultyModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }

    public record PcInputOutputDeviceModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }

    public record ExamAidModel
    {
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
    
    public abstract record FormStepModel
    {
        public int Step { get; set; }
        
        public string Baseurl { get; set; }
    }
    
    public record FormStepOneModel : FormStepModel
    {
        public IEnumerable<PostalCode> PostalCodes { get; init; }

        public IEnumerable<DepartmentModel> Departments { get; set; }
        
        public Dictionary<string, string> Literals { get; set; }
        
        public FormStepOneModel()
        {
            this.PostalCodes = new List<PostalCode>();

            this.Literals = new Dictionary<string, string>();
        }
    }
    
    public record FormStepTwoModel : FormStepModel 
    {
        public IEnumerable<QualificationTypeModel> QualificationTypes { get; set; }

        public FormStepTwoModel()
        {
            this.QualificationTypes = new List<QualificationTypeModel>();
        }
    }
    
    public record FormStepThreeModel : FormStepModel 
    {
        public IEnumerable<AbilityModel> AbilityModels { get; set; }
        
        public FormStepThreeModel()
        {
            this.AbilityModels = new List<AbilityModel>();
        }
    }
    
    public record FormStepFourModel : FormStepModel 
    {
        public IEnumerable<OperationalDifficultyModel> OperationalDifficultyModels { get; set; }
        
        public IEnumerable<DisabilityAidModel> PhysicalDisabilityAidModels { get; set; }
        
        public IEnumerable<DisabilityAidModel> DigitalDisabilityAidModels { get; set; }
        
        public IEnumerable<LearningDifficultyModel> LearningDifficultyModels { get; set; }
        
        public IEnumerable<PcInputOutputDeviceModel> PcInputOutputDeviceModels { get; set; }
        
        public FormStepFourModel()
        {
            this.OperationalDifficultyModels = new List<OperationalDifficultyModel>();
            this.PhysicalDisabilityAidModels = new List<DisabilityAidModel>();
            this.LearningDifficultyModels = new List<LearningDifficultyModel>();
            this.PcInputOutputDeviceModels = new List<PcInputOutputDeviceModel>();
        }
    }
    
    public record FormStepFiveModel : FormStepModel 
    {
        public IEnumerable<ExamAidModel> ExamAidModels { get; set; }
        
        public FormStepFiveModel()
        {
            this.ExamAidModels = new List<ExamAidModel>();
        }
    }
}