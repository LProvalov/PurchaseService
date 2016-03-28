'use strict';

var c = require('./config').styles;
var gulp = require('gulp');
var mainBowerFiles = require('main-bower-files');
var $ = require('gulp-load-plugins')({ pattern: ['gulp-*'] });
var browserSync = require('browser-sync');

gulp.task('purchase-styles', function () {
    return gulp.src(mainBowerFiles())
    .pipe($.filter(['**/*.css']))
    .pipe($.concat('purchase.css'))
    .pipe(gulp.dest(c.destPurchase));
});

gulp.task('app-styles', function () {
    return gulp.src(c.src)
    .pipe($.filter(['**/*.css']))
    .pipe($.concat('app.css'))
    .pipe(gulp.dest(c.destApp))
    .pipe(browserSync.reload({ stream: true }));
});

gulp.task('styles', ['purchase-styles', 'app-styles']);