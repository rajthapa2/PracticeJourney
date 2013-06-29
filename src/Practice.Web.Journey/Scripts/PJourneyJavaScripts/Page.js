practice_journey.Page = function (sectionName, pageTitle, sections) {
    var self = this;
    self.PageTitle = pageTitle;
    self.Sections = sections;
    self.SectionName = sectionName;
    self.Remove = function () {
        var pageElement = document.getElementById(PageTitle);
        if (pageElement) {
            ko.removeNode(pageElement);
        }
    };

    self.CreateWith = function (pageToShow) {

        var pageTemplate = document.getElementById(pageToShow + '-template').innerHTML;
        $(document.getElementById('car-journey')).append('<section class=\page\'id="' + pageToShow + '">' + pageTemplate + "</section>");
    };
};