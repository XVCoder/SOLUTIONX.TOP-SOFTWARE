var versions = ["1.0.0.5", "1.0.0.6","1.0.0.7","1.0.0.8","1.0.1.1","1.0.1.2","1.0.1.3","1.0.1.5"];
function ShowVersions() {
    document.write('<!DOCTYPE html><html><head><link rel="stylesheet" type="text/css" media="screen" href="main.css" /></head><body>');
    versions.forEach(element => {
        document.writeln("<a class='item' style='display:block' href='../AccountPad/InstallationPackages/" + element + ".rar'>版本：" + element + "</a>")
    });
    document.writeln('</body></html>');
}