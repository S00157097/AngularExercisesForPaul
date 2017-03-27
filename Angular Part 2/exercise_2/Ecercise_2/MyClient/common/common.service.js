(function () {
    'use strict';

    let app = angular.module('common.services', [
        'ngResource'
    ]);


    app.constant('appSettings', {
        serverPath: 'http://localhost:3181'
    });

}());