﻿using Hometask.DataAnalyzer.Core.Models.CarModels;
using Hometask.DataAnalyzer.Core.Models.ResultModels;
using Hometask.DataAnalyzer.Core.Operations;

namespace Hometask.DataAnalyzer.Core.Operation.ArrayOperations.CarArrayOperations;

public class ArrayFastestCarOperation : IOperation<Car[], FastestCarResult>
{
    public FastestCarResult Process(Car[] cars)
    {
        ArgumentNullException.ThrowIfNull(cars, nameof(cars));

        var carList = cars.ToList();
        var highestSpeed = carList.MaxBy(c => c.Speed).Speed;

        int firstCarIndex = carList.FindIndex(c => c.Speed == highestSpeed);
        int lastCarIndex = carList.FindLastIndex(c => c.Speed == highestSpeed);

        return new FastestCarResult(firstCarIndex, lastCarIndex);
    }
}
