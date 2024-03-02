window.CreateDOMElement = function CreateDOMElement(tagName, parent, id) {
    var element = document.createElement(tagName);
    element.id = id;
    parent.appendChild(element);
    return element;
}

window.AddListenerToCell = function AddListenerToCell(currentCell, currentElement, popUpContainerOverlay, popUpContainer) {
    currentCell.addEventListener('click', function (event) {

        event.preventDefault();

        popUpContainerOverlay.style.display = 'block';
        popUpContainer.style.display = 'block';

        popUpContainer.addEventListener('click', function (event2) {
            event2.stopPropagation();
        });

        popUpContainerOverlay.addEventListener('click', function (event2) {
            event2.preventDefault();

            popUpContainer.style.display = 'none';
            popUpContainerOverlay.style.display = 'none';
            popUpContainer.innerHTML = '';
        });

        var main = window.CreateDOMElement('main', popUpContainer, 'popUpMain');

        var header = window.CreateDOMElement('header', main, 'popUpHeader');

        var article1 = window.CreateDOMElement('article', header, 'popUpArticle1');

        article1.textContent = 'Свойства на елемента';

        var xMark = window.CreateDOMElement('a', header, 'xMark');
        xMark.textContent = '✘';

        xMark.addEventListener('click', function (event2) {
            event2.preventDefault();
            popUpContainer.style.display = 'none';
            popUpContainerOverlay.style.display = 'none';
            popUpContainer.innerHTML = '';
        });

        var article2 = window.CreateDOMElement('article', main, 'popUpArticle2');

        var section1 = window.CreateDOMElement('section', article2, 'popUpSection1');

        var elementClasses = Array.from(currentCell.classList);

        for (var i = 0; i < elementClasses.length; i++) {
            var currentClass = elementClasses[i];
            section1.classList.add(currentClass);
        }

        section1.style.backgroundColor = currentCell.style.backgroundColor;
        section1.style.border = currentCell.style.border;

        var h1_1 = window.CreateDOMElement('h1', section1, 'popUpH1_1');
        h1_1.textContent = currentElement.Symbol;

        var p1 = window.CreateDOMElement('p', section1, 'popUpP1');
        p1.textContent = currentElement.Name;

        var p2 = window.CreateDOMElement('p', section1, 'popUpP2');
        p2.textContent = currentElement.ChemicalType.BulgarianName;

        var section2 = window.CreateDOMElement('section', article2, 'popUpSection2');

        var table = window.CreateDOMElement('table', section2, 'popUpTable');

        var p = window.CreateDOMElement('p', section1, 'popUpP');
        p.textContent = currentElement.AtomicNumber;

        window.PopulateTable(table, currentElement, 3);
    }
    )
};

window.PopulateTable = function PopulateTable(table, currentElement, counter) {
    //First Row
    window.CreateTableRows(counter, table, 'Агрегатно състояние:', currentElement.BulgarianState);
    counter += 2;

    //Second Row
    window.CreateTableRows(counter, table, 'Период:', currentElement.Period);
    counter += 2;

    //Third Row
    window.CreateTableRows(counter, table, 'Група:', currentElement.Group);
    counter += 2;

    //Fourth Row
    window.CreateTableRows(counter, table, 'Електроотрицателност:', currentElement.Electronegativity);
    counter += 2;

    //Fifth Row
    window.CreateTableRows(counter, table, 'Атомна Маса:', `${currentElement.AtomicMass} u`);
    counter += 2;

    //Sixth Row
    window.CreateTableRows(counter, table, 'Атомен Радиус:', `${currentElement.AtomicRadius} pm`);
    counter += 2;

    //Seventh Row
    window.CreateTableRows(counter, table, 'Плътност:', `${currentElement.Density} g / cm³`);
    counter += 2;

    //Eighth Row
    window.CreateTableRows(counter, table, 'Температура на топене:', `${currentElement.MeltingPoint} K`);
    counter += 2;

    //Ninth Row
    window.CreateTableRows(counter, table, 'Температура на кипене:', `${currentElement.BoilingPoint} K`);
    counter += 2;

    //Tenth Row
    window.CreateTableRows(counter, table, 'Електронни Слоеве:', currentElement.ElectronicLayers);
    counter += 2;

    //Eleventh Row
    if (currentElement.IsRadioactive) {
        window.CreateTableRows(counter, table, 'Радиоктивен:', 'Да');
    }
    else {
        window.CreateTableRows(counter, table, 'Радиоктивен:', 'Не');
    }
    counter += 2;

    //Twelfth Row
    if (currentElement.IsSynthetic) {
        window.CreateTableRows(counter, table, 'Синтетичен:', 'Да');
    }
    else {
        window.CreateTableRows(counter, table, 'Синтетичен:', 'Не');
    }
}

window.AddValidation = function AddValidation()
{
    console.log('test');
    var element = document.getElementById('validationTitle');
    setTimeout(function () {
        element.style.display = 'none';
    }, 1);
};

window.CreateTableRows = function CreateTableRows(number, table, textContent, elementProperty) {

    var tr = window.CreateDOMElement('tr', table, `popUpTr${number}`);

    var th = window.CreateDOMElement('th', tr, `popUpTh${number}`);

    var p = window.CreateDOMElement('p', th, `popUpP${number}`);
    p.textContent = textContent;

    var td = window.CreateDOMElement('td', tr, `popUpTd${number}`);

    var p1 = window.CreateDOMElement('p', td, `popUpP${number + 1}`);
    p1.textContent = elementProperty;
}