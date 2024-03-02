function PageSettings(model) {

    var popUpContainerOverlay = document.getElementById("popUpContainerOverlay");
    var popUpContainer = document.getElementById("popUpContainer");

    popUpContainerOverlay.style.display = 'none';
    popUpContainer.style.display = 'none';

    function UpdateElement(element, className) {
        element.classList = [];
        if (className != null) {
            element.classList.add(className);
        }
        element.style = null;
    }

    function ShowElementError(number) {
        var errorDiv = document.getElementsByClassName(`errorDiv${number}`)[0];
        errorDiv.style.display = 'block';

        setTimeout(function () {
            errorDiv.style.display = 'none';
        }, 3000);
    }

    function CreateEventListeners(cellsCollectionArray, values, select,
        yearInputField, elementInputField, darkModeBtn) {

        select.addEventListener('change', function (event) {
            event.preventDefault();

            var selectedIndex = select.selectedIndex;
            var selectedOption = select.options[selectedIndex].id;
            yearInputField.style.display = 'none';
            elementInputField.style.display = 'none';

            for (var i = 0; i < cellsCollectionArray.length; i++) {

                var currentCell = cellsCollectionArray[i];
                var currentValue = values[i];

                if (selectedOption == 'seeAtomicNumber') {

                    var chemicalType = currentValue.ChemicalType.Name;
                    UpdateElement(currentCell, null);

                    for (var j = 0; j < chemicalType.split(' ').length; j++) {
                        currentCell.classList.add(chemicalType.split(' ')[j]);
                    }

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seeAtomicMass') {

                    var mass = currentValue.AtomicMass * 0.60;

                    UpdateElement(currentCell, 'hasAtomicMass');

                    currentCell.style.backgroundColor = `rgba(115, ${235 - mass}, 255)`;

                    currentCell.style.border = `3px solid rgba(115, ${160 - mass}, 255)`;

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seePhysicalAppearance') {

                    var state = currentValue.State;

                    UpdateElement(currentCell, state);

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seeAtomicRadius') {

                    var atomicRadius = parseFloat(currentValue.AtomicRadius) / parseFloat(5);

                    UpdateElement(currentCell, 'hasAtomicRadius');

                    if (atomicRadius > 0) {
                        currentCell.style.backgroundColor = `rgba(0, ${atomicRadius * 2.5}, 70)`;

                        currentCell.style.border = `3px solid rgba(0, ${atomicRadius * 2.5}, 60)`;
                    }
                    else {

                        currentCell.style.backgroundColor = `rgba(0, 62, 70)`;

                        currentCell.style.border = `3px solid rgba(0, 52, 60)`;
                    }

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seeMeltingPoint') {

                    var meltingPoint = parseFloat(currentValue.MeltingPoint) / parseFloat(31);

                    UpdateElement(currentCell, 'hasMeltingPoint');

                    currentCell.style.backgroundColor = `rgba(${meltingPoint * 2.5}, 30, 70)`;

                    currentCell.style.border = `3px solid rgba(${meltingPoint * 4}, 30, 60)`;

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seeBoilingPoint') {
                    var boilingPoint = parseFloat(currentValue.BoilingPoint) / parseFloat(31);

                    UpdateElement(currentCell, 'hasBoilingPoint');

                    currentCell.style.backgroundColor = `rgba(${boilingPoint}, 0, 0)`;

                    currentCell.style.border = `3px solid rgba(${boilingPoint * 0.6}, 0, 0)`;

                    currentCell.style.cursor = 'pointer';
                }

                else if (selectedOption == 'seeByYear') {
                    yearInputField.style.display = 'inline-block';
                    currentCell.style.cursor = 'pointer';
                    break;
                }

                else if (selectedOption == 'seeByName') {
                    elementInputField.style.display = 'inline-block';
                    currentCell.style.cursor = 'pointer';
                    break;
                }
            }

        });

        yearInputField.addEventListener('focus', function (event) {
            for (var i = 0; i < cellsCollectionArray.length; i++) {
                var chemicalType = values[i].ChemicalType.Name;

                var currentCell = cellsCollectionArray[i];

                UpdateElement(currentCell, null);

                for (var j = 0; j < chemicalType.split(' ').length; j++) {
                    currentCell.classList.add(chemicalType.split(' ')[j]);
                }
            }
        });

        yearInputField.addEventListener('blur', function (event) {
            event.preventDefault();

            var yearValue = yearInputField.value;

            if (!yearValue || yearValue == '' || yearValue == ' ' || yearValue < 0 || yearValue > 2024) {
                ShowElementError(1);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var currYear = values[i].YearFound;
                    var currentCell = cellsCollectionArray[i];
                        
                    if (currYear > yearValue) {
                        var cell = cellsCollectionArray[i];
                        UpdateElement(cell, 'hasNotYear');
                    }

                    currentCell.style.cursor = 'pointer';
                }
            }
        });

        elementInputField.addEventListener('focus', function (event) {
            for (var i = 0; i < cellsCollectionArray.length; i++) {
                var chemicalType = values[i].ChemicalType.Name;

                var currentCell = cellsCollectionArray[i];

                UpdateElement(currentCell, null);

                for (var j = 0; j < chemicalType.split(' ').length; j++) {
                    currentCell.classList.add(chemicalType.split(' ')[j]);
                }
            }
        });

        elementInputField.addEventListener('blur', function (event) {
            event.preventDefault();

            var elementIsFound = false;
            var elementValue = elementInputField.value;

            if (!elementInputField || elementInputField == '' || elementInputField == ' ') {
                ShowElementError(2);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var currName = values[i].Name;
                    var currentCell = cellsCollectionArray[i];
                    currentCell.style.cursor = 'pointer';
                    if (currName == elementValue) {
                        elementIsFound = true;
                        break;
                    }
                }
            }

            if (elementIsFound == false) {
                ShowElementError(2);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var currName = values[i].Name;
                    if (currName != elementValue) {
                        var cell = cellsCollectionArray[i];
                        UpdateElement(cell, 'hasNotName');
                    }
                }
            }
        });

        darkModeBtn.addEventListener('click', function (event) {

            event.preventDefault();

            var textContent = darkModeBtn.textContent;
            var header = document.querySelector('body > header');

            if (textContent == 'Dark Mode') {
                darkModeBtn.textContent = 'Light Mode';
                UpdateElement(darkModeBtn, 'lightModeBtn');
                UpdateElement(header, 'bg-white');
            }
            else {
                darkModeBtn.textContent = 'Dark Mode';
                UpdateElement(darkModeBtn, 'darkModeBtn');
                UpdateElement(header, 'bg-black');
            }
        });
    }

    function CreatePopUpMenu(cellsCollectionArray, values) {
        for (var i = 0; i < cellsCollectionArray.length; i++) {

            var currentCell = cellsCollectionArray[i];
            var currentElement = values[i];

            currentCell.style.cursor = 'pointer';

            window.AddListenerToCell(currentCell, currentElement,
                popUpContainerOverlay, popUpContainer);
        }
    }

    var values = Array.from(model).sort((a, b) => a.AtomicNumber - b.AtomicNumber);

    var select = document.getElementById('seeItemsList');

    var cellsCollection = document.getElementsByTagName('td');

    var cellsCollectionArray = Array.from(cellsCollection)
        .filter(x => x.classList.length != 0).sort((a, b) =>
        a.getElementsByClassName('atomicNumber')[0].textContent -
            b.getElementsByClassName('atomicNumber')[0].textContent);

    var yearInputField = document.getElementsByClassName('yearInput')[0];
    var elementInputField = document.getElementsByClassName('elementInput')[0];
    var darkModeBtn = document.getElementsByClassName('darkModeBtn')[0];

    CreatePopUpMenu(cellsCollectionArray, values);
   
    CreateEventListeners(cellsCollectionArray, values,
        select, yearInputField, elementInputField, darkModeBtn);
}
