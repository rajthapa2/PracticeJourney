practice_journey.JourneyModel = function (pages) {
    var self = this;
    self.DefaultPage = (pages ? pages[0] : null);
    self.CurrentPage = ko.observable(self.DefaultPage);

    self.Pages = pages;
    self.Init = function (pageName, sectionName) {
        self.ShowPage(pageName, sectionName);
    };

//    var getPageByName = function (pageName) {
//        var page = ko.utils.arrayFirst(pages, function (page) {
//            return page.Name === pageName;
//        });
//        return page;
//    };

    self.ShowPage = function (pageName, sectionName) {
        pageName = pageName && pageName.length > 0 ? pageName : self.DefaultPage;
        sectionName = sectionName && sectionName.length > 0 ? sectionName : null;
//        var page = getPageByName(pageName);
        var page = practice_journey.Pages()[0];
        self.CurrentPage().Remove();
        page.CreateWith(sectionName);
        self.CurrentPage(page);
    };
};