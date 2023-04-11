import UIKit
import Foundation

@objc public class AirDropSharing: NSObject {

    @objc public func shareFile(filePath: String, unityViewController: UIViewController) {
        let fileURL = URL(fileURLWithPath: filePath)

        let activityViewController = UIActivityViewController(activityItems: [fileURL], applicationActivities: nil)
        activityViewController.excludedActivityTypes = [.assignToContact, .saveToCameraRoll, .postToFacebook, .postToTwitter, .postToWeibo, .message, .mail, .copyToPasteboard, .print]
        
        unityViewController.present(activityViewController, animated: true, completion: nil)
    }
}