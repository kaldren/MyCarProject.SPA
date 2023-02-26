namespace Troshka.SPA.Models.Car;

public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the entity id property
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the entity IsDeleted property
    /// </summary>
    public bool IsDeleted { get; set; }

    public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Gets or sets the entity last update property
    /// </summary>
    public DateTimeOffset? DateUpdated { get; set; }

    /// <summary>
    /// Gets or sets the entity deletion date
    /// </summary>
    public DateTimeOffset? DateDeleted { get; set; }
}

public class CarOfferModel : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public virtual OwnerEntityModel Owner { get; set; }
    public virtual CarSpecificationEntityModel Specification { get; set; }
    public virtual CarEquipmentEntityModel Equipment { get; set; }
}

public class OwnerEntityModel
{
    public string DisplayName { get; set; }
    public string Phone { get; set; }
    public bool IsDisplayNamePublic { get; set; }
}

public class CarSpecificationEntityModel
{
    public int Year { get; set; }
    public int HorsePowers { get; set; }
    public int Mileage { get; set; }
    public bool IsRegistered { get; set; }
    public DateTimeOffset FirstRegistration { get; set; }
    public virtual CarEngineEntityModel Engine { get; set; }
    public virtual CarEuroStandardEntityModel Euro { get; set; }
    public virtual CarTransmissionEntityModel Transmission { get; set; }
    public virtual CarColorEntityModel Color { get; set; }
    public virtual CarSeatsEntityModel Seats { get; set; }
    public virtual CarDoorsEntityModel Doors { get; set; }
    public virtual CarInteriorMaterialEntityModel InteriorMaterial { get; set; }
    public virtual CarColorEntityModel InteriorColor { get; set; }
    public string BrandId { get; set; }
    public virtual CarBrandEntityModel Brand { get; set; }
    public string ModelId { get; set; }
    public virtual CarModelEntityModel Model { get; set; }
}

public class CarEngineEntityModel
{
    public string Name { get; set; }
}

public class CarEuroStandardEntityModel
{
    public string Name { get; set; }
}

public class CarTransmissionEntityModel
{
    public string Name { get; set; }
}

public class CarColorEntityModel
{
    public string Name { get; set; }
}

public class CarSeatsEntityModel
{
    public int Value { get; set; }
}

public class CarDoorsEntityModel
{
    public string Name { get; set; }
}

public class CarInteriorMaterialEntityModel
{
    public string Name { get; set; }
}

public class CarBrandEntityModel
{
    public string Name { get; set; }
}

public class CarModelEntityModel
{
    public string Name { get; set; }
    public string CarBrandId { get; set; }
    public virtual CarBrandEntityModel CarBrand { get; set; }
}

public class CarEquipmentEntityModel
{
    public bool HasABS { get; set; }
    public bool HasESP { get; set; }
    public bool HasASR { get; set; }
    public bool HasHillStartAssist { get; set; }
    public bool HasFatigueWarningSystem { get; set; }
    public bool HasLaneChangeAssist { get; set; }
    public bool HasBlindSpotAssist { get; set; }
    public bool HasNightVisionAssist { get; set; }
    public bool HasEmergencyBrakeAssist { get; set; }
    public bool HasEmergencyCallSystem { get; set; }
    public bool HasTrafficSignRecognition { get; set; }
    public bool HasCruiseControl { get; set; }
    public bool HasAdaptiveCruiseControl { get; set; }
    public bool HasSpeedLimitControlSystem { get; set; }
    public bool HasDistanceWarningSystem { get; set; }
    public bool HasDriverAirbag { get; set; }
    public bool HasFrontAirbags { get; set; }
    public bool HasFrontAndSideAirbags { get; set; }
    public bool HasFrontAndSideAndMoreAirbags { get; set; }
    public bool HasIsofix { get; set; }
    public bool HasBiXenonHeadlights { get; set; }
    public bool HasLaserHeadlights { get; set; }
    public bool HasLedHeadlights { get; set; }
    public bool HasXenonHeadlights { get; set; }
    public bool HasHeadlightWasherSystem { get; set; }
    public bool HasGlareFreeHighBeamHeadlights { get; set; }
    public bool HasHighBeamAssist { get; set; }
    public bool HasAdaptiveCorneringLights { get; set; }
    public bool HasAdaptiveLighting { get; set; }
    public bool HasFogLamps { get; set; }
    public bool HasAlarm { get; set; }
    public bool HasEngineImobilizer { get; set; }

    // Comfort
    public bool HasAirConditioner { get; set; }
    public bool HasClimateControl { get; set; }
    public bool HasHeatedWindshield { get; set; }
    public bool HasHeatedSteeringWheel { get; set; }
    public bool HasSelfSteeringSystems { get; set; }
    public bool HasFrontParkAssistant { get; set; }
    public bool HasRearParkAssistant { get; set; }
    public bool HasCameraAssistant { get; set; }
    public bool Has360DegreeCameraAssistant { get; set; }
    public bool HasFrontHeatedSeats { get; set; }
    public bool HasBackHeatedSeats { get; set; }
    public bool HasFrontAdjustableSeats { get; set; }
    public bool HasBackAdjustableSeats { get; set; }
    public bool HasSportSeats { get; set; }
    public bool HasArmRest { get; set; }
    public bool HasMassageSeats { get; set; }
    public bool HasSeatVentilation { get; set; }
    public bool HasElectricWindows { get; set; }
    public bool HasElectricSideMirror { get; set; }
    public bool HasElectricTailgate { get; set; }
    public bool HasCentralLocking { get; set; }
    public bool HasKeylessCentralLocking { get; set; }
    public bool HasLightSensor { get; set; }
    public bool HasRainSensor { get; set; }
    public bool HasPowerAssistedSteering { get; set; }
    public bool HasAmbientLighting { get; set; }
    public bool HasLeatherSteeringWheel { get; set; }

    // Devices
    public bool HasRadio { get; set; }
    public bool HasCDPlayer { get; set; }
    public bool HasTV { get; set; }
    public bool HasNavigationSystem { get; set; }
    public bool HasSoundSystem { get; set; }
    public bool HasTouchScreen { get; set; }
    public bool HasVoiceControl { get; set; }
    public bool HasMultifunctionSteeringWheel { get; set; }
    public bool HasHandsfreeKit { get; set; }
    public bool HasUSBPort { get; set; }
    public bool HasBluetooth { get; set; }
    public bool HasAppleCarPlay { get; set; }
    public bool HasAndroidAuto { get; set; }
    public bool HasOnboardComputer { get; set; }
    public bool HasHeadupDisplay { get; set; }
    public bool HasDigitalCockpit { get; set; }

    // Other
    public bool HasSummerTires { get; set; }
    public bool HasWinterTires { get; set; }
    public bool HasAllSeasonTires { get; set; }
    public bool HasEmergencyTire { get; set; }
    public bool HasEmergencyTireKit { get; set; }
    public bool HasPanoramicRoof { get; set; }
}