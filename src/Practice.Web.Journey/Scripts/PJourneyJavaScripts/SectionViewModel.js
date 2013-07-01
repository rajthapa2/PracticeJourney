practice_journey.SectionViewModel = function () {
    this.SaveActionUrl = "";
    this.Save = function () {
        var serviceClient = new practice_journey.ServiceClient();
        serviceClient.post(this.SaveActionUrl, this.ToJSON());
    };
};