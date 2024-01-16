const { series } = require("gulp");
const gulp = require("gulp");
const postcss = require("gulp-postcss");
const tailwindcss = require("tailwindcss");
var rename = require('gulp-rename');
var cssmin = require('gulp-cssmin');
const glob = require("glob");
var exec = require('gulp-exec');


var getDirectories = function (src, callback) {
    glob(src + '/**/*razor', callback);
};

const Config = {
    cssPath: "./Styles/input.css",
    ComponentPath: "./components"
};
const options = {
    continueOnError: false, // default = false, true means don't emit error event
    pipeStdout: false, // default = false, true means stdout is written to file.contents
};
function buildTask(element) {
    var reportOptions = {
        err: true, // default = true, false means don't write err
        stderr: true, // default = true, false means don't write stderr
        stdout: true // default = true, false means don't write stdout
    };
    // console.log("rm -rf " + './obj/Debug/net6.0/scopedcss/' + element + ".rz.scp.css");
    return gulp.src(Config.cssPath)
        .pipe(exec("rm -rf " + './obj/Debug/net6.0/scopedcss/' + element + ".rz.scp.css", options))
        .pipe(postcss([tailwindcss({
            content: [element],
            theme: {
            },
            plugins: [
                require('@tailwindcss/typography'),
                require('@tailwindcss/forms'),
                require('@tailwindcss/line-clamp'),
                require('@tailwindcss/aspect-ratio'),
                require('flowbite/plugin'),
                require('tailwind-clip-path'),
            ],
            darkMode: 'class',
        }), require("autoprefixer")]))
        .pipe(rename(element + '.css'))
        .pipe(cssmin())
        .pipe(gulp.dest("./"))

}
function intTasks() {
    const promise = new Promise(async function (resolve, reject) {
        getDirectories(Config.ComponentPath, function (err, res) {
            if (err) {
                console.log('Error', err);
                resolve([]);
            } else {
                let arr = [];
                res.forEach(element => {
                    arr.push(buildTask(element));
                });
                resolve(arr);
            }
        });
    });
    return promise;
}



function watchTasks() {
    return gulp.watch(["**/*.razor"]).on("change", (file) => {
        console.log(file + " changed!");
        buildTask(file)


    });
}
exports.default = series(intTasks, watchTasks);