using System;

namespace sentimentDetection
{
    public class SentimentDetection
    {
        public string GetResponses(string input)
        {
            string[] words = input.ToLower().Split(new char[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);
            // Sentiment keywords
            string[] worriedKeywords = { "worried", "scared", "nervous", "afraid", "anxious" };
            string[] curiousKeywords = { "curious", "interested", "wondering", "want to know" };
            string[] frustratedKeywords = { "frustrated", "confused", "lost", "angry", "overwhelmed" };

            string sentimentResponse = "";

            foreach (string word in words)
            {
                if (Array.Exists(worriedKeywords, w => w == word))
                {
                    sentimentResponse = "It’s completely understandable to feel that way. Online threats like scams can be very convincing. ";
                    break;
                }
                else if (Array.Exists(curiousKeywords, w => w == word))
                {
                    sentimentResponse = "That’s a great question! Curiosity helps you stay safe online. ";
                    break;
                }
                else if (Array.Exists(frustratedKeywords, w => w == word))
                {
                    sentimentResponse = "I'm here to help you. Cybersecurity can seem confusing, but you're doing great by asking. ";
                    break;
                }
            }

            // keywords for cybersecurity topics
            string[] purposeKeywords = { "purpose" };
            string[] cybersecurityKeywords = { "cybersecurity", "cyber", "security" };
            string[] examplesKeywords = { "examples" };
            string[] virusKeywords = { "virus", "harmful program" };
            string[] ransomwareKeywords = { "ransomware", "harmful software" };
            string[] spywareKeywords = { "spyware", "type of software" };
            string[] databreachKeywords = { "data breach", "stolen" };
            string[] phishingKeywords = { "phishing", "phish", "fake email", "scam", "scams" }; // added "scam" and "scams"
            string[] passwordSafetyKeywords = { "password", "safe password", "password safety", "password manager" };
            string[] safeBrowsingKeywords = { "safe browsing", "browsing", "safe" };
            string[] denialofservicesKeywords = { "overload", "hackers", "denial", "dos", "ddos" };
            string[] malwareKeywords = { "malware" };
            string[] waystopreventcyberattcksKeywords = { "prevent", "ways", "protection", "avoid" };

            string[] responses = new string[14];

            foreach (string word in words)
            {
                if (Array.Exists(purposeKeywords, element => element == word))
                    responses[0] = "My purpose is to educate you about online safety and cybersecurity.";

                if (Array.Exists(cybersecurityKeywords, element => element == word))
                    responses[1] = "Cybersecurity is the practice of protecting systems, networks, and data from cyber threats. You can ask me about phishing, malware, or password safety.";

                if (Array.Exists(examplesKeywords, element => element == word))
                    responses[2] = "Examples of cyber threats include viruses, phishing, ransomware, spyware, data breaches, denial-of-service attacks, and malware.";

                if (Array.Exists(virusKeywords, element => element == word))
                    responses[3] = "A computer virus is a harmful program that spreads between computers and can damage files or steal information.";

                if (Array.Exists(ransomwareKeywords, element => element == word))
                    responses[4] = "Ransomware is a harmful program that locks files or systems until a ransom is paid.";

                if (Array.Exists(spywareKeywords, element => element == word))
                    responses[5] = "Spyware is a software that secretly gathers data from your device without your permission.";

                if (Array.Exists(databreachKeywords, element => element == word))
                    responses[6] = "A data breach occurs when private or sensitive information is accessed or disclosed without authorization.";

                if (Array.Exists(phishingKeywords, element => element == word))
                    responses[7] = "Phishing is when attackers trick you into revealing personal information through fake emails, websites, or messages.";

                if (Array.Exists(passwordSafetyKeywords, element => element == word))
                    responses[8] = "To stay safe, use strong passwords and consider a password manager. Avoid reusing passwords across sites.";

                if (Array.Exists(safeBrowsingKeywords, element => element == word))
                    responses[9] = "Safe browsing means using secure websites, avoiding suspicious links, and keeping your browser up to date.";

                if (Array.Exists(denialofservicesKeywords, element => element == word))
                    responses[10] = "Denial-of-service (DoS) attacks flood systems with traffic, making them unavailable to users.";

                if (Array.Exists(malwareKeywords, element => element == word))
                    responses[11] = "Malware is software designed to harm your device or steal information.";

                if (Array.Exists(waystopreventcyberattcksKeywords, element => element == word))
                    responses[12] = "To prevent cyberattacks: use strong passwords, avoid suspicious emails, update your software, and install antivirus protection.";
            }

            string finalResponse = string.Join(" ", Array.FindAll(responses, element => element != null));

            return !string.IsNullOrEmpty(finalResponse)
                ? sentimentResponse + finalResponse
                : sentimentResponse + "I'm not sure I understood. Try asking me about topics like phishing, malware, or how to protect your password.";
        }

    }
}