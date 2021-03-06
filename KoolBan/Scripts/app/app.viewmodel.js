﻿function AppViewModel(dataModel) {
    var self = this;
    self.dataModel = dataModel;


    self.cleanUpLocation = function() {
        window.location.hash = "";
    }

    // Data
    self.Views = {
        Loading: {} // Other views are added dynamically by app.addViewModel(...).
    };

    // Other navigateToX functions are added dynamically by app.addViewModel(...).
    self.addViewModel = function (options) {
        var viewItem = new options.factory(self, dataModel),
            navigator;

        // Add view to AppViewModel.Views enum (for example, app.Views.Home).
        self.Views[options.name] = viewItem;

        // Add binding member to AppViewModel (for example, app.home);
        self[options.bindingMemberName] = ko.computed(function () {
            return self.Views[options.name];
        });

        if (typeof (options.navigatorFactory) !== "undefined") {
            navigator = options.navigatorFactory(self, dataModel);
        } else {
            navigator = function () {
                window.location.hash = options.bindingMemberName;
            };
        }

        // Add navigation member to AppViewModel (for example, app.NavigateToHome());
        self["navigateTo" + options.name] = function () {
            window.location.hash = options.name;
        };

        //this one is used by sammy to perform actual default routing
        self["_navigateTo" + options.name] = function () {
            navigator();
        };
    };

    self.initialize = function () {
        Path.listen();
    }
}

var app = new AppViewModel(new AppDataModel());