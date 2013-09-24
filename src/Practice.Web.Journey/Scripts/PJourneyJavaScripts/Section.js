practice_journey.Section = function (sectionName, viewModel, title) {
    var self = this;
    self.SectionName = sectionName;
    self.ViewModel = viewModel;
    self.Title = title;
    var successCallback = function () {
        alert('Risk is now saved');
    };

    self.FinishSection = function () {

        self.ViewModel.Save(successCallback);
    };
    self.InitializeBindings = function (sectionName) {
        sectionName = sectionName || document.getElementById(self.SectionName);
        ko.applyBindings(self, sectionName);
    };
};