﻿using OpenHardwareMonitor.Hardware;

namespace TTController.Common
{
    public interface ICacheProvider
    {
        float GetSensorValue(Identifier sensor);
        SensorConfig GetSensorConfig(Identifier sensor);
        PortData GetPortData(PortIdentifier port);
        PortConfig GetPortConfig(PortIdentifier port);
    }
}
