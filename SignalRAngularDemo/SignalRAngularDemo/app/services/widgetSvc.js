
// The widget service is a function responsible for bootstrapping the SignalR 
// widgets hub proxy. It exposes the sendRequest() function to invoke the sendWidget
// dynamic method on the hub.
//
// This service was written by Ravi Kiran and documented on his blog at
// http://sravi-kiran.blogspot.com/2013/09/ABetterWayOfUsingAspNetSignalRWithAngularJs.html


//service: return a instance 
//app.service('widgetSvc', function ($, $rootScope) {
//    var proxy = null;

//    var initialize = function () {

//        // fetch connection object and create proxy
//        var connection = $.hubConnection();
//        this.proxy = connection.createHubProxy('widgets');

//        // start connection
//        connection.start();

//        this.proxy.on('newWidget', function (data) {
//            $rootScope.$emit("newWidget", data);
//        });
//    };

//    var sendRequest = function () {
//        // invoke sendWidget method defined in hub
//        this.proxy.invoke('sendWidget');
//    };

//    return {
//        initialize: initialize,
//        sendRequest: sendRequest
//    };
//});




//factory: return a object with properties.
app.factory('widgetSvc', function ($, $rootScope) {

    var service = {};

    var proxy = null;

    service.initialize = function () {

        // fetch connection object and create proxy
        var connection = $.hubConnection();
        this.proxy = connection.createHubProxy('widgets');

        // start connection
        connection.start();

        this.proxy.on('newWidget', function (data) {
            $rootScope.$emit("newWidget", data);
        });
    };

    service.sendRequest = function () {
        // invoke sendWidget method defined in hub
        this.proxy.invoke('sendWidget');
    };

    return service;
});