var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Amcacik');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);