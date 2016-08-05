var express = require('express');
var userFunctions = require('../modules/userFunctions.js');
var router = express.Router();

router.post('/register', function (req, res, next) {
    console.log(req.body);
    var lol = {
        success: true
    };
    res.send(lol);
});

router.post('/login', function (req, res, next) {

});

router.get('/forgot', function (req, res, next) {

});

router.post('/forgot', function (req, res, next) {

});

module.exports = router;
