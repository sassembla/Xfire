import UIKit
import Foundation

@objc public class AirDropSharing: NSObject {

    @objc public static func shareFile() {
        guard let documentsURL = FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first else {
            fatalError("Unable to access Documents directory")
        }
        
        let fileName = "xfire/data.txt"
        let fileURL = documentsURL.appendingPathComponent(fileName)

        let activityViewController = UIActivityViewController(activityItems: [fileURL], applicationActivities: nil)
        activityViewController.excludedActivityTypes = [.assignToContact, .saveToCameraRoll, .postToFacebook, .postToTwitter, .postToWeibo, .message, .mail, .copyToPasteboard, .print]
        
        getMainWindow()?.rootViewController?.present(activityViewController, animated: true, completion: nil)
    }
    
    private static func getMainWindow() -> UIWindow? {
        let app = UIApplication.shared

        for window in app.windows {
            if window.isKeyWindow {
                return window
            }
        }

        return nil
    }
}
