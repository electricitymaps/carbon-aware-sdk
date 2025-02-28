namespace CarbonAware.Interfaces;

internal interface IForecastDataSource
{
    /// <summary>
    /// Gets the current forecasted carbon intensity for a location
    /// </summary>
    /// <param name="location">The location that should be used for getting the forecast.</param>
    /// <returns>A forecasted emissions object for the given location.</returns>
    Task<EmissionsForecast> GetCurrentCarbonIntensityForecastAsync(Location location);

    /// <summary>
    /// Gets the forecasted carbon intensity for a location up to a given horizon in the future.
    /// <param name="location">The location that should be used for getting the forecast.</param>
    /// <param name="horizonHours">The number of hours into the future to get the forecast for.</param>
    /// <returns>A forecasted emissions object for the given location up to the given horizon.</returns>
    Task<EmissionsForecast> GetCarbonIntensityForecastAsync(Location location, int horizonHours);
    /// <summary>
    /// Gets the forecasted carbon intensity for a location generated at a requested time
    /// <param name="location">The location that should be used for getting the forecast.</param>
    /// <param name="requestedAt">The historical time used to fetch the most recent forecast generated as of that time.</param>
    /// <returns>A forecasted emissions object for the given location generated at the given time.</returns>
    Task<EmissionsForecast> GetHistoricalCarbonIntensityForecastAsync(Location location, DateTimeOffset requestedAt);
}