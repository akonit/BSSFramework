﻿namespace Framework.DomainDriven.ServiceModel.Service;

public class EvaluatedData<TBLLContext>
{
    public EvaluatedData(IDBSession session, TBLLContext context)
    {
        this.Session = session ?? throw new ArgumentNullException(nameof(session));
        this.Context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IDBSession Session
    {
        get;
    }

    public TBLLContext Context
    {
        get;
    }
}

public class EvaluatedData<TBLLContext, TDTOMappingService> : EvaluatedData<TBLLContext>
{
    public EvaluatedData(IDBSession session, TBLLContext context, TDTOMappingService mappingService)
            : base(session, context)
    {
        this.MappingService = mappingService ?? throw new ArgumentNullException(nameof(mappingService));
    }

    public TDTOMappingService MappingService
    {
        get;
    }
}
