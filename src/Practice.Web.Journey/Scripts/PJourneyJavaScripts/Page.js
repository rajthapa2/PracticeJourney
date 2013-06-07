practice_journey.Page = function (pageName, title, sections) {
    var self = this;
    self.Name = pageName;
    self.Title = title;
    self.Sections = sections;

    self.Remove = function () {
        var pageElement = document.getElementById(pageName);
        if (pageElement) {
            ko.removeNode(pageElement);
        }
    };

    self.CreateWith = function (pageToShow) {

        var pageTemplate = document.getElementById(pageName + '-template').innerHTML;
        $(document.getElementById('car-journey')).append('<section class=\page\'id="' + pageName + '">' + pageTemplate + "</section>");
    };
};