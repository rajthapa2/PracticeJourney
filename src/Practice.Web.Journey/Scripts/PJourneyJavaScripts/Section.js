practice_journey.Section = function (sectionName, viewModel, title) {
    var self = this;
    self.SectionName = sectionName;
    self.ViewModel = viewModel;
    self.Title = title;
    self.FinishSection = function () {
        self.ViewModel.Save();
    };
    self.InitializeBindings = function (sectionName) {
        sectionName = sectionName || document.getElementById(self.SectionName);
        ko.applyBindings(self, sectionName);
    };
};