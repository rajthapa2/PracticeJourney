practice_journey.SectionViewModel = function () {
    this.saveActionUrl = "";
    this.Save = function () {
        var serviceClient = new practice_journey.ServiceClient();
        serviceClient.post(this.saveActionUrl, this.ToJSON());
    };
};