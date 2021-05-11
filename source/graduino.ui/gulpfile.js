const gulp = require('gulp');
const uglify = require('gulp-uglify');
const cssnano = require('gulp-cssnano');
const autoprefixer = require('gulp-autoprefixer');
const sass = require('gulp-sass');
const sourcemaps = require('gulp-sourcemaps');
const { task } = require('gulp');
const mode = require('gulp-mode')();

gulp.task('build-sass', () =>
{
    return gulp.src('src/scss/index.scss')
        .pipe(mode.development(sourcemaps.init()))
        .pipe(sass().on('error', sass.logError))
        .pipe(autoprefixer({
            overrideBrowserslist: ['> 1%']
        }))
        .pipe(cssnano())
        .pipe(mode.development(sourcemaps.write()))
        .pipe(gulp.dest('dist/css'));
});

gulp.task('build', gulp.series('build-sass'));

gulp.task('default', () => 
{
    gulp.watch(
        ['src/scss/*.scss','src/scss/*/*.scss'],
        { ignoreInitial: false },
        gulp.series('build-sass')
    );
});