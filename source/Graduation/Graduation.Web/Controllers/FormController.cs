using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Graduation.Core;
using Graduation.Core.Data;
using Graduation.Web.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation.Web.Controllers
{
    public class FormController : Controller
    {
        private readonly ILocalizationManager _localizationManager;
        private readonly IPostalCodeProviderService _postalCodeProviderService;
        private readonly EducationContext _educationContext;

        public FormController(IPostalCodeProviderService postalCodeProviderService, EducationContext educationContext,  ILocalizationManager localizationManager)
        {
            this._postalCodeProviderService = postalCodeProviderService;
            this._educationContext = educationContext;
            
            this._localizationManager = localizationManager;
        }
        
        [Route("{controller}/{step:range(1,5)?}")]
        public async Task<IActionResult> Index(CancellationToken cancellationToken, int step = 1)
        {
            FormStepModel model = null;

            var currentUri = GetUrl(this.ControllerContext.HttpContext.Request);
            
            if (step == 1)
            {
                var departments = await this._educationContext.Departments
                    .Include(x => x.DepartmentLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);

                model = new FormStepOneModel
                {
                    Step = step,
                    Baseurl = $"{currentUri.Scheme}://{currentUri.Host}{currentUri.AbsolutePath}",
                    PostalCodes = (await this._postalCodeProviderService.GetPostalCodesAsync(cancellationToken))?.OrderBy(x => x.Code).ToList() ?? new List<PostalCode>(),
                    Departments = departments
                        .Where(x => x.DepartmentLocalizations.Any())
                        .Select(x => new DepartmentModel
                        {
                            Code = x.Code,
                            Name = x.DepartmentLocalizations.FirstOrDefault(x => x.LanguageId == 1)?.Name ?? string.Empty
                        }),
                    Literals = new List<LocalizedResource>
                        {
                            await this._localizationManager.GetValueAsync(1, FormStepOneLocalizedResourceKeys.StudentDetails, cancellationToken),
                            await this._localizationManager.GetValueAsync(1, FormStepOneLocalizedResourceKeys.ContactInfo, cancellationToken),
                        }
                        .ToDictionary(x => x.Key, x => x.Value)
                };
            }

            if (step == 2)
            {
                var qualificationTypes = await this._educationContext.QualificationTypes
                    .Include(x => x.QualificationTypeLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);

                model = new FormStepTwoModel
                {
                    Step = step,
                    Baseurl = $"{currentUri.Scheme}://{currentUri.Host}{currentUri.AbsolutePath}",
                    QualificationTypes = qualificationTypes
                        .Select(x => new QualificationTypeModel
                        {
                            Name = x?.QualificationTypeLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Name ?? x.DefaultName
                        })
                        .ToList()
                };
            }
            
            if (step == 3)
            {
                var abilities = await this._educationContext.Abilities
                    .Include(x => x.AbilityLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);
                
                model = new FormStepThreeModel
                {
                    Step = step,
                    Baseurl = $"{currentUri.Scheme}://{currentUri.Host}{currentUri.AbsolutePath}",
                    AbilityModels = abilities
                        .Select(x => new AbilityModel
                        {
                            Code =  x.Code,
                            Title = x?.AbilityLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.AbilityLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList()
                };
            }
            
            if (step == 4)
            {
                var operationalDifficulties = await this._educationContext.OperationalDifficulties
                    .Include(x => x.OperationalDifficultyLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);
                
                var pcIoDevices = await this._educationContext.PcInputOutputDevices
                    .Include(x => x.PcInputOutputDeviceLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);

                var aids = await this._educationContext.DisabilityAids
                    .Include(x => x.DisabilityAidLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);
                
                var learningDifficulties = await this._educationContext.LearningDifficulties
                    .Include(x => x.LearningDifficultyLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);
                
                model = new FormStepFourModel
                {
                    Step = step,
                    Baseurl = $"{currentUri.Scheme}://{currentUri.Host}{currentUri.AbsolutePath}",
                    OperationalDifficultyModels = operationalDifficulties
                        .Select(x => new OperationalDifficultyModel
                        {
                            Code =  x.Code,
                            Title = x?.OperationalDifficultyLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.OperationalDifficultyLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList(),
                    PhysicalDisabilityAidModels = aids
                        .Where(x => x.DisabilityAidType == DisabilityAidType.Physical)
                        .Select(x => new DisabilityAidModel
                        {
                            Code =  x.Code,
                            Title = x?.DisabilityAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.DisabilityAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList(),
                    DigitalDisabilityAidModels = aids
                        .Where(x => x.DisabilityAidType == DisabilityAidType.Digital)
                        .Select(x => new DisabilityAidModel
                        {
                            Code =  x.Code,
                            Title = x?.DisabilityAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.DisabilityAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList(),
                    PcInputOutputDeviceModels = pcIoDevices
                        .Select(x => new PcInputOutputDeviceModel
                        {
                            Code =  x.Code,
                            Title = x?.PcInputOutputDeviceLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.PcInputOutputDeviceLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList(),
                    LearningDifficultyModels = learningDifficulties
                        .Select(x => new LearningDifficultyModel
                        {
                            Code =  x.Code,
                            Title = x?.LearningDifficultyLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.LearningDifficultyLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList(),
                };
            }
            
            if (step == 5)
            {
                var examAids = await this._educationContext.ExamAids
                    .Include(x => x.ExamAidLocalizations.Where(l => l.LanguageId == 1))
                    .ToListAsync(cancellationToken);

                model = new FormStepFiveModel
                {
                    Step = step,
                    Baseurl = $"{currentUri.Scheme}://{currentUri.Host}{currentUri.AbsolutePath}",
                    ExamAidModels = examAids
                        .Select(x => new ExamAidModel
                        {
                            Code = x.Code,
                            Title = x?.ExamAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Title ?? x.DefaultTitle,
                            Description = x?.ExamAidLocalizations?.FirstOrDefault(l => l.LanguageId == 1)?.Description ?? x.DefaultDescription
                        })
                        .ToList()
                };
            }
            
            return this.View(model);
        }
        
        
        private static Uri GetUrl(HttpRequest request)
        {
            var uriBuilder = new UriBuilder();

            var host = request.Headers.TryGetValue("X-Forwarded-Host", out var _host)
                ? new HostString(_host.ToString().NullIfEmpty() ?? request.Host.ToString())
                : request.Host;

            var scheme = request.Headers.TryGetValue("X-Forwarded-Proto", out var _proto)
                ? _proto.ToString().NullIfEmpty() ?? request.Scheme
                : request.Scheme;

            var port = host.Port ?? -1;

            if (scheme.Equals("http", StringComparison.OrdinalIgnoreCase) && port == 80)
            {
                port = -1;
            }

            if (scheme.Equals("https", StringComparison.OrdinalIgnoreCase) && port == 443)
            {
                port = -1;
            }

            uriBuilder.Scheme = scheme;
            uriBuilder.Host = host.Host;
            uriBuilder.Port = host.Port ?? -1;
            uriBuilder.Path = request.Path.HasValue ? request.Path.Value : string.Empty;
            uriBuilder.Query = request.QueryString.HasValue ? request.QueryString.Value : string.Empty;

            return uriBuilder.Uri;
        }
    }
}