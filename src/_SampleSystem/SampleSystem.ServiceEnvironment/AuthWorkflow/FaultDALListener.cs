﻿using Framework.DomainDriven;

namespace SampleSystem.ServiceEnvironment;

public class FaultDALListener : IBeforeTransactionCompletedDALListener
{
    public bool Raise { get; set; }

    public void Process(DALChangesEventArgs eventArgs)
    {
        if (this.Raise)
        {
            throw new Exception(nameof(FaultDALListener));
        }
    }
}
