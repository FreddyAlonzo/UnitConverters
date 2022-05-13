const baseURL = ''
// Temperature
function convertTemperature() {
    let temperatureValue = document.getElementById("temperatureValue").value;
    let unitFrom = document.getElementById("temperatureFrom").value;
    let unitTo = document.getElementById("temperatureTo").value;
    let temperatureConvert = baseURL + '/ConvertTemperature?value=' + temperatureValue + '&UnitsFrom=' + unitFrom +'&UnitsTo=' + unitTo;

    fetch(temperatureConvert).then(response => {
        return response.json();
    }).then(data => {
        if(data.value == undefined)
        {
            document.getElementById("tempResult").innerHTML = "Please enter a valid value.";
        }
        else {
            let resultstr = data.value + " " + data.units;
            document.getElementById("tempResult").innerHTML = resultstr;
        }
    console.log(data.error);
    }).catch(err => {
    // Do something for an error here
    });
    }
function calculateTemperature() {
    let temperature1 = document.getElementById("temperature1").value;
    let temperature1Unit = document.getElementById("temperature1Unit").value;
    let temperatureOperator = document.getElementById("temperatureOperator").value;
    let temperature2 = document.getElementById("temperature2").value;
    let temperature2Unit = document.getElementById("temperature2Unit").value;
    let temperatureCalculate = baseURL + '/AddTemperature?firstValue=' + temperature1 + '&firstUnit=' + temperature1Unit + '&operation=' + temperatureOperator +  '&secondValue=' + temperature2 + '&secondUnit=' + temperature2Unit;
    fetch(temperatureCalculate).then(response => {
        return response.json();
    }).then(data => {
        if(data.firstValue == undefined) {
            document.getElementById("temperatureResult1").innerHTML = "Please enter valid values.";
            document.getElementById("temperatureResult2").innerHTML = "";
        }
        else {
            let temperatureResult1 = data.firstValue + " " + data.firstTemperatureUnits;
            document.getElementById("temperatureResult1").innerHTML = temperatureResult1;
            let temperatureResult2 = data.secondValue + " " + data.secondTemperatureUnits;
            document.getElementById("temperatureResult2").innerHTML = temperatureResult2;
        }       
    console.log(data);
    }).catch(err => {
    // Do something for an error here
    });
}

// Length
function convertLength() {
    let lengthValue = document.getElementById("lengthValue").value;
    let unitFrom = document.getElementById("lengthFrom").value;
    let unitTo = document.getElementById("lengthTo").value;
    let lengthConvert = baseURL + '/ConvertLength?value=' + lengthValue + '&UnitsFrom=' + unitFrom +'&UnitsTo=' + unitTo;

    fetch(lengthConvert).then(response => {
        return response.json();
    }).then(data => {
        if(data.value == undefined)
        {
            document.getElementById("lengthResult").innerHTML = "Please enter a valid value.";
        }
        else {
            let resultstr = data.value + " " + data.units;
            document.getElementById("lengthResult").innerHTML = resultstr;
        }
    console.log(data.error);
    }).catch(err => {
    // Do something for an error here
    });
    }
function calculateLength() {
    let length1 = document.getElementById("length1").value;
    let length1Unit = document.getElementById("length1Unit").value;
    let lengthOperator = document.getElementById("lengthOperator").value;
    let length2 = document.getElementById("length2").value;
    let length2Unit = document.getElementById("length2Unit").value;
    let lengthCalculate = baseURL + '/AddLength?firstValue=' + length1 + '&firstUnit=' + length1Unit + '&operation=' + lengthOperator +  '&secondValue=' + length2 + '&secondUnit=' + length2Unit;
    fetch(lengthCalculate).then(response => {
        return response.json();
    }).then(data => {
        if(data.firstValue == undefined) {
            document.getElementById("lengthResult1").innerHTML = "Please enter valid values.";
            document.getElementById("lengthResult2").innerHTML = "";
        }
        else {
            let lengthResult1 = data.firstValue + " " + data.firstLengthUnits;
            document.getElementById("lengthResult1").innerHTML = lengthResult1;
            let lengthResult2 = data.secondValue + " " + data.secondLengthUnits;
            document.getElementById("lengthResult2").innerHTML = lengthResult2;
        }       
    console.log(data);
    }).catch(err => {
    // Do something for an error here
    });
}

// Weight
function convertWeight() {
    let weightValue = document.getElementById("weightValue").value;
    let unitFrom = document.getElementById("weightFrom").value;
    let unitTo = document.getElementById("weightTo").value;
    let weightConvert = baseURL + '/ConvertWeight?value=' + weightValue + '&UnitsFrom=' + unitFrom +'&UnitsTo=' + unitTo;

    fetch(weightConvert).then(response => {
        return response.json();
    }).then(data => {
        if(data.value == undefined)
        {
            document.getElementById("weightResult").innerHTML = "Please enter a valid value.";
        }
        else {
            let resultstr = data.value + " " + data.units;
            document.getElementById("weightResult").innerHTML = resultstr;
        }
    console.log(data.error);
    }).catch(err => {
    // Do something for an error here
    });
    }
function calculateWeight() {
    let weight1 = document.getElementById("weight1").value;
    let weight1Unit = document.getElementById("weight1Unit").value;
    let weightOperator = document.getElementById("weightOperator").value;
    let weight2 = document.getElementById("weight2").value;
    let weight2Unit = document.getElementById("weight2Unit").value;
    let weightCalculate = baseURL + '/AddWeight?firstValue=' + weight1 + '&firstUnit=' + weight1Unit + '&operation=' + weightOperator +  '&secondValue=' + weight2 + '&secondUnit=' + weight2Unit;
    fetch(weightCalculate).then(response => {
        return response.json();
    }).then(data => {
        if(data.firstValue == undefined) {
            document.getElementById("weightResult1").innerHTML = "Please enter valid values.";
            document.getElementById("weightResult2").innerHTML = "";
        }
        else {
            let weightResult1 = data.firstValue + " " + data.firstWeightUnits;
            document.getElementById("weightResult1").innerHTML = weightResult1;
            let weightResult2 = data.secondValue + " " + data.secondWeightUnits;
            document.getElementById("weightResult2").innerHTML = weightResult2;
        }       
    console.log(data);
    }).catch(err => {
    // Do something for an error here
    });
}

//Height
function changeHeightConversion() {
    var mToI = document.getElementById("HeightMToI");
    var iToM = document.getElementById("HeightIToM");
    if (document.getElementById("heightConversionType").value === "MetricToImperial") {
        mToI.style.display = "block";
        iToM.style.display = "none";
    }
    else if (document.getElementById("heightConversionType").value === "ImperialToMetric") {
        mToI.style.display = "none";
        iToM.style.display = "block";
    }
}

function changeHeightCalculation() {
    var MetricFirst = document.getElementById("MetricFirst");
    var ImperialFirst = document.getElementById("ImperialFirst");
    if (document.getElementById("firstHUnit").value === "Metric") {
        MetricFirst.style.display = "block";
        ImperialFirst.style.display = "none";
    }
    else if (document.getElementById("firstHUnit").value === "Imperial") {
        MetricFirst.style.display = "none";
        ImperialFirst.style.display = "block";
    }
}

function convertHeightToMetric() {
    let feetValue = document.getElementById("feetValue").value;
    let inchesValue = document.getElementById("inchesValue").value;
    let heightConvertToMetric = baseURL + '/ConvertHeightToMetric/?feetValue=' + feetValue + '&inchesValue=' + inchesValue;

    fetch(heightConvertToMetric).then(response => {
        return response.json();
    }).then(data => {
        if(data.value1 == undefined)
        {
            document.getElementById("metricResult").innerHTML = "Please enter a valid value.";
        }
        else {
            let resultstr = data.value1 + " " + data.units1 + " " + data.value2 + " " + data.units2;
            document.getElementById("metricResult").innerHTML = resultstr;
        }
    console.log(data.error);
    }).catch(err => {
    // Do something for an error here
    });
}

function convertHeightToImperial() {
    let metersValue = document.getElementById("metersValue").value;
    let centimetersValue = document.getElementById("centimetersValue").value;
    let heightConvertToImperial = baseURL + '/ConvertHeightToImperial/?metersValue=' + metersValue + '&centimetersValue=' + centimetersValue;

    fetch(heightConvertToImperial).then(response => {
        return response.json();
    }).then(data => {
        if(data.value1 == undefined)
        {
            document.getElementById("imperialResult").innerHTML = "Please enter a valid value.";
        }
        else {
            let resultstr = data.value1 + " " + data.units1 + " " + data.value2 + " " + data.units2;
            document.getElementById("imperialResult").innerHTML = resultstr;
        }
    console.log(data.error);
    }).catch(err => {
    // Do something for an error here
    });
}

//https://localhost:7035/AddHeightMI?metersValue=2&centimetersValue=3&operations=Add&feetValue=2&inchesValue=3
function heightMetricFirst() {
    let metersValueA1 = document.getElementById("metersValueA1").value;
    let centimetersValueA1 = document.getElementById("centimetersValueA1").value;
    let heightOperator1 = document.getElementById("heightOperator1").value;
    let feetValueA1 = document.getElementById("feetValueA1").value;
    let inchesValueA1 = document.getElementById("inchesValueA1").value;
    let heightMetricFirst = baseURL + '/AddHeightMI?metersValue=' + metersValueA1 + '&centimetersValue=' + centimetersValueA1 + '&operation=' + heightOperator1 +  '&feetValue=' + feetValueA1 + '&inchesValue=' + inchesValueA1;
    fetch(heightMetricFirst).then(response => {
        return response.json();
    }).then(data => {
        if(data.firstValue == undefined) {
            document.getElementById("heightMetricFirstResult").innerHTML = "Please enter valid values.";
            document.getElementById("heightMetricFirstResult2").innerHTML = "";
        }
        else {
            let heightResult1 = data.firstValue + " " + data.firstHeightUnits + " " + data.firstValue1 + " " + data.firstHeightUnits1;
            document.getElementById("heightMetricFirstResult").innerHTML = heightResult1;
            let heightResult2 = data.secondValue + " " + data.secondHeightUnits + " " + data.secondValue1 + " " + data.secondHeightUnits1;
            document.getElementById("heightMetricFirstResult2").innerHTML = heightResult2;
        }       
    console.log(data);
    }).catch(err => {
    // Do something for an error here
    });
}

//https://localhost:7035/AddHeightMI?metersValue=2&centimetersValue=3&operations=Add&feetValue=2&inchesValue=3
function heightImperialFirst() {
    let metersValueA2 = document.getElementById("metersValueA2").value;
    let centimetersValueA2 = document.getElementById("centimetersValueA2").value;
    let heightOperator2 = document.getElementById("heightOperator2").value;
    let feetValueA2 = document.getElementById("feetValueA2").value;
    let inchesValueA2 = document.getElementById("inchesValueA2").value;
    let heightImperialFirst = baseURL + '/AddHeightIM?feetValue=' + feetValueA2 + '&inchesValue=' + inchesValueA2 + '&operation=' + heightOperator2 +  '&metersValue=' + metersValueA2 + '&centimetersValue=' + centimetersValueA2;
    fetch(heightImperialFirst).then(response => {
        return response.json();
    }).then(data => {
        if(data.firstValue == undefined) {
            document.getElementById("heightImperialFirstResult").innerHTML = "Please enter valid values.";
            document.getElementById("heightImperialFirstResult2").innerHTML = "";
        }
        else {
            let heightResult1 = data.firstValue + " " + data.firstHeightUnits + " " + data.firstValue1 + " " + data.firstHeightUnits1;
            document.getElementById("heightImperialFirstResult").innerHTML = heightResult1;
            let heightResult2 = data.secondValue + " " + data.secondHeightUnits + " " + data.secondValue1 + " " + data.secondHeightUnits1;
            document.getElementById("heightImperialFirstResult2").innerHTML = heightResult2;
        }       
    console.log(data);
    }).catch(err => {
    // Do something for an error here
    });
}