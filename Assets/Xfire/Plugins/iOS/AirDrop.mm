 #import <UnityFramework/UnityFramework-Swift.h>

 #ifdef __cplusplus
 extern "C" {
 #endif
    void _shareFile(NSString* data) {
        NSLog(@"called Swift mm");
        [AirDropSharing shareFile];
    }
 #ifdef __cplusplus
 }
 #endif
