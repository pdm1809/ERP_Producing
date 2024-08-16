using AutoMapper;
using SampleProject.Business.Abstractions;
using SampleProject.Data.UnitOfWork;
using SampleProject.Shared.Providers.Abstractions;
using SampleProject.Shared.Settings;

namespace SampleProject.Business.Implements
{
    public abstract class BusinessBase : IBusiness
    {
        protected readonly IUnitOfWorkService _unitOfWorkService;
        protected readonly ICoreProvider _coreProvider;
        protected readonly IMapper _mapper;
        protected readonly SampleProjectSetting _setting;

        protected BusinessBase(IUnitOfWorkService unitOfWorkService,
            ICoreProvider coreProvider)
        {
            _unitOfWorkService = unitOfWorkService;
            _setting = coreProvider.Setting;
            _mapper = coreProvider.Mapper;
            _coreProvider = coreProvider;
        }
    }
}
