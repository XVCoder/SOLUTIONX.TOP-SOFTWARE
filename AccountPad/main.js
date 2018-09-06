var versions = ["1.0.0.6"];
function ShowVersions() {
    versions.forEach(element => {
        document.writeln("<a class='item' href='../InstallationPackages/" + element + ".rar'>版本：" + element + "</a>")
    });
}