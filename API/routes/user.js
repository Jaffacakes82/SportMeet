var express = require('express');
var userFunctions = require('../modules/userFunctions.js');
var router = express.Router();

router.post('/register', function (req, res, next) {
    if ((typeof req.body.Id !== 'undefined' && req.body.Id) &&
        (typeof req.body.Username !== 'undefined' && req.body.Username) &&
        (typeof req.body.EmailAddress !== 'undefined' && req.body.EmailAddress) &&
        (typeof req.body.FirstName !== 'undefined' && req.body.FirstName) &&
        (typeof req.body.LastName !== 'undefined' && req.body.LastName) &&
        (typeof req.body.Password !== 'undefined' && req.body.Password)) {
        var toRegister = {
            Id: req.body.Id,
            Username: req.body.Username,
            EmailAddress: req.body.EmailAddress,
            FirstName: req.body.FirstName,
            LastName: req.body.LastName,
            Password: req.body.Password
        }

        console.warn(toRegister);

        userFunctions.registerUser(toRegister, function (success) {
            if (success) {
                res.send({
                    success: true
                });
            } else {
                res.send({
                    success: false
                });
            }
        });
    } else {
        res.send({
            success: false
        });
    }
});

router.post('/login', function (req, res, next) {
    if ((typeof req.body.Username !== 'undefined' && req.body.Username) &&
        (typeof req.body.Password !== 'undefined' && req.body.Password)) {
        var toLogin = {
            Username: req.body.Username,
            Password: req.body.Password
        }

        console.warn(toLogin);

        userFunctions.loginUser(toLogin, function (login) {
            if (login.success) {
                res.send({
                    AuthToken: login.AuthToken,
                    Success: true
                });
            } else {
                res.send({
                    AuthToken: '',
                    Success: false
                });
            }
        });
    } else {
        res.send({
            AuthToken: '',
            Success: false
        });
    }
});

router.get('/forgot', function (req, res, next) {

});

router.post('/forgot', function (req, res, next) {

});

module.exports = router;
